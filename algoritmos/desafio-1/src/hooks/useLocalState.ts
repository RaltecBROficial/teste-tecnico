import { useState, useEffect } from 'react'

function useLocalState<T>(
  key: string,
  initialValue: T,
): [T, (value: T) => void] {
  const getLocalState = (): T | null => {
    const storedValue = localStorage.getItem(key)

    if (storedValue) {
      try {
        return JSON.parse(storedValue)
      } catch (error) {
        // eslint-disable-next-line no-console
        console.error(
          `Error parsing local storage value for key '${key}':`,
          error,
        )
      }
    }

    return initialValue
  }

  const [state, setState] = useState<T>(() => getLocalState() as T)

  useEffect(() => {
    localStorage.setItem(key, JSON.stringify(state))
  }, [key, state])

  return [state, setState]
}

export default useLocalState
